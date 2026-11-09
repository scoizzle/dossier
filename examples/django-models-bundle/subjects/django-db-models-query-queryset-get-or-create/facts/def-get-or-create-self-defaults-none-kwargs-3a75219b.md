# Fact 3a75219b

Store id: 819d78c9-9a68-4463-8da5-63b6b918be81

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
- posted_at: `2026-11-09T23:44:55.9250360+00:00`

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
  "id": "819d78c9-9a68-4463-8da5-63b6b918be81",
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
    "posted_at": "2026-11-09T23:44:55.9250360+00:00"
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
  "subject_id": "27bc5a39-b3c1-42d1-a5c8-2712d2ec65f0",
  "subject_name": "django/db/models/query::QuerySet.get_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def get_or_create(self, defaults=None, **kwargs)"
}
```
