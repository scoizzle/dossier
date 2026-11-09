# Fact edcb5419

Store id: 7a5dd1e6-0451-4657-8f77-593f68cf3a55

## Text

```text
class DecimalField(Field)
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
- posted_at: `2026-11-09T22:39:42.4430260+00:00`

## Data

```json
{
  "end_line": 1933,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1740,
  "symbol": "DecimalField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1740,"selector":"L1740-L1933","symbol":"DecimalField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1933,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1740,
    "symbol": "DecimalField"
  },
  "id": "7a5dd1e6-0451-4657-8f77-593f68cf3a55",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4430260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1740,
        "selector": "L1740-L1933",
        "symbol": "DecimalField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "25ff08c8-f0d2-423c-b20d-a1f93aa7e99b",
  "subject_name": "django/db/models/fields/__init__::DecimalField",
  "tags": [
    "entity:class"
  ],
  "text": "class DecimalField(Field)"
}
```
