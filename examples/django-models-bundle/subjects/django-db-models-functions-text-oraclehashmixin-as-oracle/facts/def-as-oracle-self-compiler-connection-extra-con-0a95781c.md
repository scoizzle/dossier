# Fact 0a95781c

Store id: 786bc85f-8802-4a60-ad51-c9dcd0f74dbe

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:02.1284060+00:00`

## Data

```json
{
  "end_line": 28,
  "entity_kind": "method",
  "parent": "OracleHashMixin",
  "start_line": 19,
  "symbol": "OracleHashMixin.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L28","symbol":"OracleHashMixin.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::OracleHashMixin.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 28,
    "entity_kind": "method",
    "parent": "OracleHashMixin",
    "start_line": 19,
    "symbol": "OracleHashMixin.as_oracle"
  },
  "id": "786bc85f-8802-4a60-ad51-c9dcd0f74dbe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1284060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L28",
        "symbol": "OracleHashMixin.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "727f78a6-a3f5-48dc-a7f6-32047018248d",
  "subject_name": "django/db/models/functions/text::OracleHashMixin.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
