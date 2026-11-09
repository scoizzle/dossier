# Fact d7251772

Store id: ef6ea413-a18a-4a31-a867-ac52601dbedc

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
- posted_at: `2026-11-09T23:44:49.9865450+00:00`

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
  "id": "ef6ea413-a18a-4a31-a867-ac52601dbedc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9865450+00:00"
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
  "subject_id": "9be077cb-e493-4f16-9cde-5d3b7b651a12",
  "subject_name": "django/db/models/fields/__init__::Field.choices",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def choices(self)"
}
```
