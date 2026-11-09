# Fact 9be930d1

Store id: 9a16e6f9-66d3-494d-93e0-53560b40ac36

## Text

```text
def update_or_create(self, defaults=None, create_defaults=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.4483900+00:00`

## Data

```json
{
  "end_line": 1139,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1095,
  "symbol": "QuerySet.update_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1095,"selector":"L1095-L1139","symbol":"QuerySet.update_or_create"}`

## Items

```json
[
  {
    "text": "Look up an object with the given kwargs, updating one with defaults if it exists, otherwise create a new one. Optionally, an object can be created with different values than defaults by using create_defaults. Return a tuple (object, created), where created is a boolean specifying whether an object was created.",
    "locator": {
      "line": 1096
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.update_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1139,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1095,
    "symbol": "QuerySet.update_or_create"
  },
  "id": "9a16e6f9-66d3-494d-93e0-53560b40ac36",
  "items": [
    {
      "locator": {
        "line": 1096
      },
      "text": "Look up an object with the given kwargs, updating one with defaults if it exists, otherwise create a new one. Optionally, an object can be created with different values than defaults by using create_defaults. Return a tuple (object, created), where created is a boolean specifying whether an object was created."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4483900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1095,
        "selector": "L1095-L1139",
        "symbol": "QuerySet.update_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "09a9251d-84b4-4e05-8628-97f0dacec523",
  "subject_name": "django/db/models/query::QuerySet.update_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def update_or_create(self, defaults=None, create_defaults=None, **kwargs)"
}
```
