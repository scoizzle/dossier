# Fact c2e0f8f7

Store id: ce895882-ff17-4c7d-9f49-5e5a51d07078

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
- posted_at: `2026-11-09T22:39:47.0431660+00:00`

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
  "id": "ce895882-ff17-4c7d-9f49-5e5a51d07078",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0431660+00:00"
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
  "subject_id": "c47d7cbe-7a4d-40e8-a1e5-ba1fc755d520",
  "subject_name": "django/db/models/functions/text::OracleHashMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class OracleHashMixin"
}
```
