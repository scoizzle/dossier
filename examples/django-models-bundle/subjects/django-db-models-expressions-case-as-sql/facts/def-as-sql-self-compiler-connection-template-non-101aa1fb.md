# Fact 101aa1fb

Store id: 46aa6938-5830-45f3-bc9f-541fadf0e77f

## Text

```text
def as_sql( self, compiler, connection, template=None, case_joiner=None, **extra_context )
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
- posted_at: `2026-11-09T23:44:49.6300580+00:00`

## Data

```json
{
  "end_line": 1802,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1761,
  "symbol": "Case.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1761,"selector":"L1761-L1802","symbol":"Case.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1802,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1761,
    "symbol": "Case.as_sql"
  },
  "id": "46aa6938-5830-45f3-bc9f-541fadf0e77f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6300580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1761,
        "selector": "L1761-L1802",
        "symbol": "Case.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e92e537e-efd8-4f98-b941-954d962580da",
  "subject_name": "django/db/models/expressions::Case.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql( self, compiler, connection, template=None, case_joiner=None, **extra_context )"
}
```
