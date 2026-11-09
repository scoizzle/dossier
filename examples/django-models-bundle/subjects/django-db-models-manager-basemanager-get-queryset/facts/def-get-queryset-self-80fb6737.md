# Fact 80fb6737

Store id: 115f8b6a-3c6f-4695-af19-4d7d6fe31224

## Text

```text
def get_queryset(self)
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
- posted_at: `2026-11-09T22:39:48.5228750+00:00`

## Data

```json
{
  "end_line": 155,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 150,
  "symbol": "BaseManager.get_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":150,"selector":"L150-L155","symbol":"BaseManager.get_queryset"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet object. Subclasses can override this method to customize the behavior of the Manager.",
    "locator": {
      "line": 151
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.get_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 155,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 150,
    "symbol": "BaseManager.get_queryset"
  },
  "id": "115f8b6a-3c6f-4695-af19-4d7d6fe31224",
  "items": [
    {
      "locator": {
        "line": 151
      },
      "text": "Return a new QuerySet object. Subclasses can override this method to customize the behavior of the Manager."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5228750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 150,
        "selector": "L150-L155",
        "symbol": "BaseManager.get_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "6e22fff8-16ee-460c-9d6a-4cd67648fb23",
  "subject_name": "django/db/models/manager::BaseManager.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self)"
}
```
