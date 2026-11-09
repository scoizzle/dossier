# Fact 3a75219b

Store id: 4a1a1ff3-edc9-4da4-b3fc-00c9ca78770b

## Text

```text
def get_or_create(self, defaults=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.4400770+00:00`

## Data

```json
{
  "end_line": 1083,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1060,
  "symbol": "QuerySet.get_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1060,"selector":"L1060-L1083","symbol":"QuerySet.get_or_create"}`

## Items

```json
[
  {
    "text": "Look up an object with the given kwargs, creating one if necessary. Return a tuple of (object, created), where created is a boolean specifying whether an object was created.",
    "locator": {
      "line": 1061
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.get_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1083,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1060,
    "symbol": "QuerySet.get_or_create"
  },
  "id": "4a1a1ff3-edc9-4da4-b3fc-00c9ca78770b",
  "items": [
    {
      "locator": {
        "line": 1061
      },
      "text": "Look up an object with the given kwargs, creating one if necessary. Return a tuple of (object, created), where created is a boolean specifying whether an object was created."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4400770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1060,
        "selector": "L1060-L1083",
        "symbol": "QuerySet.get_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "43b537c7-7ac5-452c-a580-38470478e21c",
  "subject_name": "django/db/models/query::QuerySet.get_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def get_or_create(self, defaults=None, **kwargs)"
}
```
