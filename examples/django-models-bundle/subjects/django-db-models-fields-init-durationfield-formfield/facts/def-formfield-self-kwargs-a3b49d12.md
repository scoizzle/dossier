# Fact a3b49d12

Store id: ddf49849-e149-490a-afa5-a02560341157

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
- posted_at: `2026-11-09T23:44:50.1353680+00:00`

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
  "id": "ddf49849-e149-490a-afa5-a02560341157",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1353680+00:00"
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
  "subject_id": "10387436-b9f5-4380-a27f-a09c97e81000",
  "subject_name": "django/db/models/fields/__init__::DurationField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
