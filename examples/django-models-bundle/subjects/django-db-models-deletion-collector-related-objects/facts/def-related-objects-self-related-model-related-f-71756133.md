# Fact 71756133

Store id: 02d54fad-96ed-4ebb-88ff-974824905028

## Text

```text
def related_objects(self, related_model, related_fields, objs)
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
- posted_at: `2026-11-09T23:31:55.1212660+00:00`

## Data

```json
{
  "end_line": 441,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 433,
  "symbol": "Collector.related_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":433,"selector":"L433-L441","symbol":"Collector.related_objects"}`

## Items

```json
[
  {
    "text": "Get a QuerySet of the related model to objs via related fields.",
    "locator": {
      "line": 434
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.related_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 441,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 433,
    "symbol": "Collector.related_objects"
  },
  "id": "02d54fad-96ed-4ebb-88ff-974824905028",
  "items": [
    {
      "locator": {
        "line": 434
      },
      "text": "Get a QuerySet of the related model to objs via related fields."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1212660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 433,
        "selector": "L433-L441",
        "symbol": "Collector.related_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "24a74626-2943-432f-a797-7fb3918e8703",
  "subject_name": "django/db/models/deletion::Collector.related_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def related_objects(self, related_model, related_fields, objs)"
}
```
