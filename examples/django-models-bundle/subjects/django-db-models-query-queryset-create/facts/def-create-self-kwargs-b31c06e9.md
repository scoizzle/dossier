# Fact b31c06e9

Store id: b9848ab7-5c1f-431c-97e8-fa5f57c4d16d

## Text

```text
def create(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.3948160+00:00`

## Data

```json
{
  "end_line": 754,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 736,
  "symbol": "QuerySet.create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":736,"selector":"L736-L754","symbol":"QuerySet.create"}`

## Items

```json
[
  {
    "text": "Create a new object with the given kwargs, saving it to the database and returning the created object.",
    "locator": {
      "line": 737
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 754,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 736,
    "symbol": "QuerySet.create"
  },
  "id": "b9848ab7-5c1f-431c-97e8-fa5f57c4d16d",
  "items": [
    {
      "locator": {
        "line": 737
      },
      "text": "Create a new object with the given kwargs, saving it to the database and returning the created object."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3948160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 736,
        "selector": "L736-L754",
        "symbol": "QuerySet.create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e0c52941-e2c3-4ce4-9517-61b81c812fc0",
  "subject_name": "django/db/models/query::QuerySet.create",
  "tags": [
    "entity:method"
  ],
  "text": "def create(self, **kwargs)"
}
```
