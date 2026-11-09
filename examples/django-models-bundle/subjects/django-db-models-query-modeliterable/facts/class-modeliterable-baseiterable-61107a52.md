# Fact 61107a52

Store id: e375cd39-5a54-4951-ab7d-aff1f11f3cec

## Text

```text
class ModelIterable(BaseIterable)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.2380940+00:00`

## Data

```json
{
  "end_line": 199,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 121,
  "symbol": "ModelIterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":121,"selector":"L121-L199","symbol":"ModelIterable"}`

## Items

```json
[
  {
    "text": "Iterable that yields a model instance for each row.",
    "locator": {
      "line": 122
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::ModelIterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 199,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 121,
    "symbol": "ModelIterable"
  },
  "id": "e375cd39-5a54-4951-ab7d-aff1f11f3cec",
  "items": [
    {
      "locator": {
        "line": 122
      },
      "text": "Iterable that yields a model instance for each row."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2380940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 121,
        "selector": "L121-L199",
        "symbol": "ModelIterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "88300414-df20-47a9-9118-b1ab140b025d",
  "subject_name": "django/db/models/query::ModelIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelIterable(BaseIterable)"
}
```
