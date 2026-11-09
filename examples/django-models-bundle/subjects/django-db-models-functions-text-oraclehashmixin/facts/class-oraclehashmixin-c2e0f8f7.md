# Fact c2e0f8f7

Store id: 6f85a495-5ce3-470d-8a01-8e04c0d7389a

## Text

```text
class OracleHashMixin
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
- posted_at: `2026-11-09T23:44:54.0337240+00:00`

## Data

```json
{
  "end_line": 28,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 18,
  "symbol": "OracleHashMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":18,"selector":"L18-L28","symbol":"OracleHashMixin"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::OracleHashMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 28,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 18,
    "symbol": "OracleHashMixin"
  },
  "id": "6f85a495-5ce3-470d-8a01-8e04c0d7389a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0337240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 18,
        "selector": "L18-L28",
        "symbol": "OracleHashMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "3946a74c-3d49-4e62-a1ab-e7d8f0606f7e",
  "subject_name": "django/db/models/functions/text::OracleHashMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class OracleHashMixin"
}
```
