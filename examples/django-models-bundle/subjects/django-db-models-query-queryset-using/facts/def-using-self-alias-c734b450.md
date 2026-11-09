# Fact c734b450

Store id: 877487de-72d0-45cb-bab3-fbd3502ee7f8

## Text

```text
def using(self, alias)
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
- posted_at: `2026-11-09T23:44:56.1105600+00:00`

## Data

```json
{
  "end_line": 2023,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2019,
  "symbol": "QuerySet.using"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2019,"selector":"L2019-L2023","symbol":"QuerySet.using"}`

## Items

```json
[
  {
    "text": "Select which database this QuerySet should execute against.",
    "locator": {
      "line": 2020
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.using](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2023,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2019,
    "symbol": "QuerySet.using"
  },
  "id": "877487de-72d0-45cb-bab3-fbd3502ee7f8",
  "items": [
    {
      "locator": {
        "line": 2020
      },
      "text": "Select which database this QuerySet should execute against."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1105600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2019,
        "selector": "L2019-L2023",
        "symbol": "QuerySet.using"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3aeedb1f-54fb-4245-b6aa-ce729b1dbb07",
  "subject_name": "django/db/models/query::QuerySet.using",
  "tags": [
    "entity:method"
  ],
  "text": "def using(self, alias)"
}
```
