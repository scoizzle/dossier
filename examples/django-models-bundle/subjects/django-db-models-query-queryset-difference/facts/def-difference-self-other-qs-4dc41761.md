# Fact 4dc41761

Store id: 8a9b05c2-9fd2-40d6-85c5-346f4385eefc

## Text

```text
def difference(self, *other_qs)
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
- posted_at: `2026-11-09T23:44:56.0577460+00:00`

## Data

```json
{
  "end_line": 1786,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1782,
  "symbol": "QuerySet.difference"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1782,"selector":"L1782-L1786","symbol":"QuerySet.difference"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.difference](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1786,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1782,
    "symbol": "QuerySet.difference"
  },
  "id": "8a9b05c2-9fd2-40d6-85c5-346f4385eefc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0577460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1782,
        "selector": "L1782-L1786",
        "symbol": "QuerySet.difference"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a94e2af5-d060-4086-b111-07479e53830f",
  "subject_name": "django/db/models/query::QuerySet.difference",
  "tags": [
    "entity:method"
  ],
  "text": "def difference(self, *other_qs)"
}
```
