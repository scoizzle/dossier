# Fact 4314c3aa

Store id: cf3a1120-af89-4931-a305-f1d8f8d03807

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
- posted_at: `2026-11-09T23:32:02.9402020+00:00`

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
  "id": "cf3a1120-af89-4931-a305-f1d8f8d03807",
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
    "posted_at": "2026-11-09T23:32:02.9402020+00:00"
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
  "subject_id": "184f43c1-ad3c-4744-8a5a-a26f0c0dcfe8",
  "subject_name": "django/db/models/indexes::Index.set_name_with_model",
  "tags": [
    "entity:method"
  ],
  "text": "def set_name_with_model(self, model)"
}
```
