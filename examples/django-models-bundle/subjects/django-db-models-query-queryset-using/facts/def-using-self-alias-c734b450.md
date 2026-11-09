# Fact c734b450

Store id: 5c69e5a3-988d-4f2a-9edb-6e7afd8fe114

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
- posted_at: `2026-11-09T23:32:04.6017290+00:00`

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
  "id": "5c69e5a3-988d-4f2a-9edb-6e7afd8fe114",
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
    "posted_at": "2026-11-09T23:32:04.6017290+00:00"
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
  "subject_id": "7637024c-2089-4f27-a8eb-57b54b224b7b",
  "subject_name": "django/db/models/query::QuerySet.using",
  "tags": [
    "entity:method"
  ],
  "text": "def using(self, alias)"
}
```
