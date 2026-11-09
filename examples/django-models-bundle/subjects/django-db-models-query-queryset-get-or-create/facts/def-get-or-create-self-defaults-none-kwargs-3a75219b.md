# Fact 3a75219b

Store id: ef8f4da3-40d4-453e-b61c-0ef521a1fc36

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
- posted_at: `2026-11-09T23:32:04.4177430+00:00`

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
  "id": "ef8f4da3-40d4-453e-b61c-0ef521a1fc36",
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
    "posted_at": "2026-11-09T23:32:04.4177430+00:00"
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
  "subject_id": "780e5f29-7d6f-4984-974b-6711f15702a4",
  "subject_name": "django/db/models/query::QuerySet.get_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def get_or_create(self, defaults=None, **kwargs)"
}
```
