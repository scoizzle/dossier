# Fact 17456dba

Store id: e7add32e-c50d-4a7d-b529-a7d788688755

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
- posted_at: `2026-11-09T23:44:53.3726870+00:00`

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
  "id": "e7add32e-c50d-4a7d-b529-a7d788688755",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3726870+00:00"
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
  "subject_id": "afb57cbe-77fb-47e9-b700-03cc9177ea64",
  "subject_name": "django/db/models/functions/datetime::Now.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
