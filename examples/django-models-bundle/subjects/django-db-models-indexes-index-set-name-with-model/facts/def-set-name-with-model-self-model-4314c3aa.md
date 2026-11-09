# Fact 4314c3aa

Store id: 1bee890c-0258-41b8-95d7-5c7eb7c2dc55

## Text

```text
def set_name_with_model(self, model)
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
- posted_at: `2026-11-09T22:39:47.8040530+00:00`

## Data

```json
{
  "end_line": 283,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 250,
  "symbol": "Index.set_name_with_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":250,"selector":"L250-L283","symbol":"Index.set_name_with_model"}`

## Items

```json
[
  {
    "text": "Generate a unique name for the index.",
    "locator": {
      "line": 251
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.set_name_with_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 283,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 250,
    "symbol": "Index.set_name_with_model"
  },
  "id": "1bee890c-0258-41b8-95d7-5c7eb7c2dc55",
  "items": [
    {
      "locator": {
        "line": 251
      },
      "text": "Generate a unique name for the index."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.8040530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 250,
        "selector": "L250-L283",
        "symbol": "Index.set_name_with_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "b11a880b-88c5-428d-bed9-1034af6d2664",
  "subject_name": "django/db/models/indexes::Index.set_name_with_model",
  "tags": [
    "entity:method"
  ],
  "text": "def set_name_with_model(self, model)"
}
```
