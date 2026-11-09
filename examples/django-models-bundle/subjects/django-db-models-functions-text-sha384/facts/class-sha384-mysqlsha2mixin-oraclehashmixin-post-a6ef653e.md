# Fact a6ef653e

Store id: 73c0ec07-ad4e-46b4-ad50-9c0fe2c2e80e

## Text

```text
class SHA384(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.1878800+00:00`

## Data

```json
{
  "end_line": 322,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 320,
  "symbol": "SHA384"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":320,"selector":"L320-L322","symbol":"SHA384"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::SHA384](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 322,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 320,
    "symbol": "SHA384"
  },
  "id": "73c0ec07-ad4e-46b4-ad50-9c0fe2c2e80e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1878800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 320,
        "selector": "L320-L322",
        "symbol": "SHA384"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "82670cf3-6e0c-486f-8ff7-ad2619ac396c",
  "subject_name": "django/db/models/functions/text::SHA384",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA384(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
