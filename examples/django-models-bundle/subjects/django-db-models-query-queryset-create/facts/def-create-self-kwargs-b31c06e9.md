# Fact b31c06e9

Store id: b48df62e-e733-4207-9b19-b2ac8d80269b

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
- posted_at: `2026-11-09T23:44:55.8993310+00:00`

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
  "id": "b48df62e-e733-4207-9b19-b2ac8d80269b",
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
    "posted_at": "2026-11-09T23:44:55.8993310+00:00"
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
  "subject_id": "96f057b1-ce51-4dbb-a2b1-45bf76221def",
  "subject_name": "django/db/models/query::QuerySet.create",
  "tags": [
    "entity:method"
  ],
  "text": "def create(self, **kwargs)"
}
```
