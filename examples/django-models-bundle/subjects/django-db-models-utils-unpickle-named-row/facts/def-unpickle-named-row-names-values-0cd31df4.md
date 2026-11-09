# Fact 0cd31df4

Store id: e471e7d2-9a24-41ed-85a8-e5ad0f0c4444

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
- posted_at: `2026-11-09T23:45:00.0322550+00:00`

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
  "id": "e471e7d2-9a24-41ed-85a8-e5ad0f0c4444",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0322550+00:00"
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
  "subject_id": "b845d95c-745c-4b1b-8e79-54e14fa0244f",
  "subject_name": "django/db/models/utils::unpickle_named_row",
  "tags": [
    "entity:function"
  ],
  "text": "def unpickle_named_row(names, values)"
}
```
