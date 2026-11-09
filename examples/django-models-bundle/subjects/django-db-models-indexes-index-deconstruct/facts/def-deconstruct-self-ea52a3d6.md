# Fact ea52a3d6

Store id: 6c7ded77-7b62-42cc-b6dc-be86a32b4137

## Text

```text
def deconstruct(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.7900660+00:00`

## Data

```json
{
  "end_line": 243,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 229,
  "symbol": "Index.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":229,"selector":"L229-L243","symbol":"Index.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 243,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 229,
    "symbol": "Index.deconstruct"
  },
  "id": "6c7ded77-7b62-42cc-b6dc-be86a32b4137",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.7900660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 229,
        "selector": "L229-L243",
        "symbol": "Index.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "2993a668-534c-4afb-abfc-475881b1bf04",
  "subject_name": "django/db/models/indexes::Index.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
