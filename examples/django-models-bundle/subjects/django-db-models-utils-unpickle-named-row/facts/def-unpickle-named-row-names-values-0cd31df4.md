# Fact 0cd31df4

Store id: 88d492e4-6772-4841-986e-2de60f86b578

## Text

```text
def unpickle_named_row(names, values)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:52.1294160+00:00`

## Data

```json
{
  "end_line": 38,
  "entity_kind": "function",
  "parent": "utils",
  "start_line": 37,
  "symbol": "unpickle_named_row"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":37,"selector":"L37-L38","symbol":"unpickle_named_row"}`

## Referenced by

None.

## Subject

[django/db/models/utils::unpickle_named_row](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 38,
    "entity_kind": "function",
    "parent": "utils",
    "start_line": 37,
    "symbol": "unpickle_named_row"
  },
  "id": "88d492e4-6772-4841-986e-2de60f86b578",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:52.1294160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 37,
        "selector": "L37-L38",
        "symbol": "unpickle_named_row"
      },
      "rel": "derived_from",
      "target": "django/db/models/utils.py"
    }
  ],
  "status": "live",
  "subject_id": "60d69f6c-fb7a-458c-a459-e4fb3f3b6769",
  "subject_name": "django/db/models/utils::unpickle_named_row",
  "tags": [
    "entity:function"
  ],
  "text": "def unpickle_named_row(names, values)"
}
```
