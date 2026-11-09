# Fact 0c910233

Store id: 4f4f4e0d-11c4-473d-ad5d-b69c10751214

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:50.0720080+00:00`

## Data

```json
{
  "end_line": 1357,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1353,
  "symbol": "CharField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1353,"selector":"L1353-L1357","symbol":"CharField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1357,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1353,
    "symbol": "CharField.deconstruct"
  },
  "id": "4f4f4e0d-11c4-473d-ad5d-b69c10751214",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0720080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1353,
        "selector": "L1353-L1357",
        "symbol": "CharField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0d236653-3f55-41d1-b94c-16140107c7d8",
  "subject_name": "django/db/models/fields/__init__::CharField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
