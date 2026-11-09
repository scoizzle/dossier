# Fact fd88ef60

Store id: 268147d5-a39e-4a5a-a8c1-19a638d17ac2

## Text

```text
class PositiveSmallIntegerField(PositiveIntegerRelDbTypeMixin, SmallIntegerField)
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
- posted_at: `2026-11-09T22:39:42.6162410+00:00`

## Data

```json
{
  "end_line": 2484,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2472,
  "symbol": "PositiveSmallIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2472,"selector":"L2472-L2484","symbol":"PositiveSmallIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveSmallIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2484,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2472,
    "symbol": "PositiveSmallIntegerField"
  },
  "id": "268147d5-a39e-4a5a-a8c1-19a638d17ac2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6162410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2472,
        "selector": "L2472-L2484",
        "symbol": "PositiveSmallIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4f5fa5a8-ce77-4545-8945-60b3b704dfc3",
  "subject_name": "django/db/models/fields/__init__::PositiveSmallIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class PositiveSmallIntegerField(PositiveIntegerRelDbTypeMixin, SmallIntegerField)"
}
```
