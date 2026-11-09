# Fact 9be930d1

Store id: 3aa805b7-82cf-4492-9890-00f9f2e97432

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
- posted_at: `2026-11-09T23:44:55.9305340+00:00`

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
  "id": "3aa805b7-82cf-4492-9890-00f9f2e97432",
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
    "posted_at": "2026-11-09T23:44:55.9305340+00:00"
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
  "subject_id": "42558a42-3a73-4d30-853b-a861d932bfcc",
  "subject_name": "django/db/models/query::QuerySet.update_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def update_or_create(self, defaults=None, create_defaults=None, **kwargs)"
}
```
