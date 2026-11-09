# Fact b31c06e9

Store id: ee2733da-12a0-4bc7-9827-77df0c40f1a8

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
- posted_at: `2026-11-09T23:32:04.3891660+00:00`

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
  "id": "ee2733da-12a0-4bc7-9827-77df0c40f1a8",
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
    "posted_at": "2026-11-09T23:32:04.3891660+00:00"
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
  "subject_id": "f685809e-9e60-4210-ba11-a2a6d8715c64",
  "subject_name": "django/db/models/query::QuerySet.create",
  "tags": [
    "entity:method"
  ],
  "text": "def create(self, **kwargs)"
}
```
