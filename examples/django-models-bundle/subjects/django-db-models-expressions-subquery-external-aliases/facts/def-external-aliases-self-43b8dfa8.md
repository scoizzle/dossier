# Fact 43b8dfa8

Store id: 6a4f180e-6913-4bd1-ba96-83481e83d6f5

## Text

```text
def external_aliases(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.6420430+00:00`

## Data

```json
{
  "end_line": 1868,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1866,
  "symbol": "Subquery.external_aliases"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1866,"selector":"L1866-L1868","symbol":"Subquery.external_aliases"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.external_aliases](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1868,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1866,
    "symbol": "Subquery.external_aliases"
  },
  "id": "6a4f180e-6913-4bd1-ba96-83481e83d6f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6420430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1866,
        "selector": "L1866-L1868",
        "symbol": "Subquery.external_aliases"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c97e48c5-9f22-4870-9623-50603bf4c6a4",
  "subject_name": "django/db/models/expressions::Subquery.external_aliases",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def external_aliases(self)"
}
```
