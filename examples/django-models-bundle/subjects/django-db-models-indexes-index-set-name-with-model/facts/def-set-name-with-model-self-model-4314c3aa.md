# Fact 4314c3aa

Store id: a35235b3-d352-44ae-af63-06968937331d

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
- posted_at: `2026-11-09T23:44:54.7026580+00:00`

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
  "id": "a35235b3-d352-44ae-af63-06968937331d",
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
    "posted_at": "2026-11-09T23:44:54.7026580+00:00"
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
  "subject_id": "a1044d71-abad-4ce0-9e4b-5e1ccc01e1c1",
  "subject_name": "django/db/models/indexes::Index.set_name_with_model",
  "tags": [
    "entity:method"
  ],
  "text": "def set_name_with_model(self, model)"
}
```
