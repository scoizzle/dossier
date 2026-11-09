# Fact 101aa1fb

Store id: 965e861d-7784-4ca3-8619-8a0fb9262365

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
- posted_at: `2026-11-09T22:39:41.7156480+00:00`

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
  "id": "965e861d-7784-4ca3-8619-8a0fb9262365",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7156480+00:00"
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
  "subject_id": "8b361652-58f1-40e7-ac8c-a7e2c5786afa",
  "subject_name": "django/db/models/expressions::Case.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql( self, compiler, connection, template=None, case_joiner=None, **extra_context )"
}
```
