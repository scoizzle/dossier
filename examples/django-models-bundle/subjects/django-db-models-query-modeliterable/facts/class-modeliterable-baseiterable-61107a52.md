# Fact 61107a52

Store id: a22ecc52-36e7-418d-a9e4-1b3ceb2b4aa2

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
- posted_at: `2026-11-09T23:44:55.7717800+00:00`

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
  "id": "a22ecc52-36e7-418d-a9e4-1b3ceb2b4aa2",
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
    "posted_at": "2026-11-09T23:44:55.7717800+00:00"
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
  "subject_id": "b23b4b00-61d3-46c4-918d-a899c21694c0",
  "subject_name": "django/db/models/query::ModelIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelIterable(BaseIterable)"
}
```
