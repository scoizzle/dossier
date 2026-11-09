# Fact 112053ac

Store id: 59a816ef-3445-47ee-876e-6e1d6c5ec8d5

## Text

```text
def formfield(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.9082170+00:00`

## Data

```json
{
  "end_line": 2928,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2927,
  "symbol": "AutoFieldMixin.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2927,"selector":"L2927-L2928","symbol":"AutoFieldMixin.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2928,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2927,
    "symbol": "AutoFieldMixin.formfield"
  },
  "id": "59a816ef-3445-47ee-876e-6e1d6c5ec8d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9082170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2927,
        "selector": "L2927-L2928",
        "symbol": "AutoFieldMixin.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "480ce02f-03a2-46fc-8306-d7a861b37b74",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
