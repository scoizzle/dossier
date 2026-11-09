# Fact 281f023b

Store id: e1543b13-f93f-4373-9631-06cd2fd1588f

## Text

```text
def earliest(self, *fields)
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
- posted_at: `2026-11-09T22:39:49.4660730+00:00`

## Data

```json
{
  "end_line": 1204,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1201,
  "symbol": "QuerySet.earliest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1201,"selector":"L1201-L1204","symbol":"QuerySet.earliest"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.earliest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1204,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1201,
    "symbol": "QuerySet.earliest"
  },
  "id": "e1543b13-f93f-4373-9631-06cd2fd1588f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4660730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1201,
        "selector": "L1201-L1204",
        "symbol": "QuerySet.earliest"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1fa9db4e-2d2e-4ed5-a32a-dba635f65f4a",
  "subject_name": "django/db/models/query::QuerySet.earliest",
  "tags": [
    "entity:method"
  ],
  "text": "def earliest(self, *fields)"
}
```
