# Fact 1a0cf011

Store id: 1f415c40-a4e0-4b7b-997a-9b84a5d9cb07

## Text

```text
class Deferred
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
- posted_at: `2026-11-09T22:39:40.3077830+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "class",
  "parent": "base",
  "start_line": 61,
  "symbol": "Deferred"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":61,"selector":"L61-L66","symbol":"Deferred"}`

## Referenced by

None.

## Subject

[django/db/models/base::Deferred](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "class",
    "parent": "base",
    "start_line": 61,
    "symbol": "Deferred"
  },
  "id": "1f415c40-a4e0-4b7b-997a-9b84a5d9cb07",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3077830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 61,
        "selector": "L61-L66",
        "symbol": "Deferred"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "ca04099e-02db-4912-bacf-5f70a11e835d",
  "subject_name": "django/db/models/base::Deferred",
  "tags": [
    "entity:class"
  ],
  "text": "class Deferred"
}
```
