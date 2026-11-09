# Fact 0cd31df4

Store id: 01fc5115-bd40-460d-b57f-92934740a1c0

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
- posted_at: `2026-11-09T23:32:07.9103660+00:00`

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
  "id": "01fc5115-bd40-460d-b57f-92934740a1c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.9103660+00:00"
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
  "subject_id": "8038e670-20f5-41b8-8454-810262771598",
  "subject_name": "django/db/models/utils::unpickle_named_row",
  "tags": [
    "entity:function"
  ],
  "text": "def unpickle_named_row(names, values)"
}
```
