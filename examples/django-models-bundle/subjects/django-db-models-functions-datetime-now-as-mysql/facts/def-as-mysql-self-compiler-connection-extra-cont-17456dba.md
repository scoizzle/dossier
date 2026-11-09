# Fact 17456dba

Store id: 3743f2ea-9c00-475b-8eba-58f4c363a0b1

## Text

```text
def as_mysql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:01.2358200+00:00`

## Data

```json
{
  "end_line": 228,
  "entity_kind": "method",
  "parent": "Now",
  "start_line": 225,
  "symbol": "Now.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":225,"selector":"L225-L228","symbol":"Now.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Now.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 228,
    "entity_kind": "method",
    "parent": "Now",
    "start_line": 225,
    "symbol": "Now.as_mysql"
  },
  "id": "3743f2ea-9c00-475b-8eba-58f4c363a0b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2358200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 225,
        "selector": "L225-L228",
        "symbol": "Now.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "842188df-0f20-4891-869a-1c1907288dab",
  "subject_name": "django/db/models/functions/datetime::Now.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
