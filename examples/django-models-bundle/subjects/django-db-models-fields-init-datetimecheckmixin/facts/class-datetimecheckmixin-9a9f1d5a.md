# Fact 9a9f1d5a

Store id: b61400cf-d4fe-4fa3-b576-841faac669d8

## Text

```text
class DateTimeCheckMixin
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
- posted_at: `2026-11-09T22:39:42.4013680+00:00`

## Data

```json
{
  "end_line": 1461,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1391,
  "symbol": "DateTimeCheckMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1391,"selector":"L1391-L1461","symbol":"DateTimeCheckMixin"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeCheckMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1461,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1391,
    "symbol": "DateTimeCheckMixin"
  },
  "id": "b61400cf-d4fe-4fa3-b576-841faac669d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4013680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1391,
        "selector": "L1391-L1461",
        "symbol": "DateTimeCheckMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a2661624-11aa-4d73-b0e1-b06405641a13",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class DateTimeCheckMixin"
}
```
