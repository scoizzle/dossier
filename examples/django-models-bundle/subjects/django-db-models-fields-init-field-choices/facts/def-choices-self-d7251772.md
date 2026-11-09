# Fact d7251772

Store id: e48369be-2042-405b-8dd2-719ea8102966

## Text

```text
def choices(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.2911050+00:00`

## Data

```json
{
  "end_line": 585,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 583,
  "symbol": "Field.choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":583,"selector":"L583-L585","symbol":"Field.choices"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 585,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 583,
    "symbol": "Field.choices"
  },
  "id": "e48369be-2042-405b-8dd2-719ea8102966",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2911050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 583,
        "selector": "L583-L585",
        "symbol": "Field.choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "67d80ee3-9fb0-4f32-9874-90b26894bb06",
  "subject_name": "django/db/models/fields/__init__::Field.choices",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def choices(self)"
}
```
