# Fact 46a1f1bf

Store id: e8d0906b-4646-4562-85b3-6e5dedc90177

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
- posted_at: `2026-11-09T23:44:50.2205140+00:00`

## Data

```json
{
  "end_line": 2469,
  "entity_kind": "method",
  "parent": "PositiveIntegerField",
  "start_line": 2463,
  "symbol": "PositiveIntegerField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2463,"selector":"L2463-L2469","symbol":"PositiveIntegerField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveIntegerField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2469,
    "entity_kind": "method",
    "parent": "PositiveIntegerField",
    "start_line": 2463,
    "symbol": "PositiveIntegerField.formfield"
  },
  "id": "e8d0906b-4646-4562-85b3-6e5dedc90177",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2205140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2463,
        "selector": "L2463-L2469",
        "symbol": "PositiveIntegerField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "92727a9f-9517-43f2-9c8b-b3b1c7b2e331",
  "subject_name": "django/db/models/fields/__init__::PositiveIntegerField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
