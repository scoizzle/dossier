# Fact a3b49d12

Store id: 8193811e-8860-4d84-a445-0cb294451303

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
- posted_at: `2026-11-09T22:39:42.4821260+00:00`

## Data

```json
{
  "end_line": 1994,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1988,
  "symbol": "DurationField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1988,"selector":"L1988-L1994","symbol":"DurationField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1994,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1988,
    "symbol": "DurationField.formfield"
  },
  "id": "8193811e-8860-4d84-a445-0cb294451303",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4821260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1988,
        "selector": "L1988-L1994",
        "symbol": "DurationField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "19585694-68ea-43c5-9984-0ef49ceeca76",
  "subject_name": "django/db/models/fields/__init__::DurationField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
