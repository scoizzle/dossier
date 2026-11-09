# Fact ea8c8999

Store id: 2e3f1f14-13eb-4de7-bfd1-694e211b7a06

## Text

```text
def contains(self, obj)
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
- posted_at: `2026-11-09T23:44:55.9961070+00:00`

## Data

```json
{
  "end_line": 1508,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1489,
  "symbol": "QuerySet.contains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1489,"selector":"L1489-L1508","symbol":"QuerySet.contains"}`

## Items

```json
[
  {
    "text": "Return True if the QuerySet contains the provided obj, False otherwise.",
    "locator": {
      "line": 1490
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.contains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1508,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1489,
    "symbol": "QuerySet.contains"
  },
  "id": "2e3f1f14-13eb-4de7-bfd1-694e211b7a06",
  "items": [
    {
      "locator": {
        "line": 1490
      },
      "text": "Return True if the QuerySet contains the provided obj, False otherwise."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9961070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1489,
        "selector": "L1489-L1508",
        "symbol": "QuerySet.contains"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "230c039a-a7c4-4b2e-8ed8-87523689dc4b",
  "subject_name": "django/db/models/query::QuerySet.contains",
  "tags": [
    "entity:method"
  ],
  "text": "def contains(self, obj)"
}
```
