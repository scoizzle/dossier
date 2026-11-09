# Fact 46a1f1bf

Store id: f2b7ad28-643b-44a5-bc1c-9c479432ce70

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
- posted_at: `2026-11-09T23:31:56.7744070+00:00`

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
  "id": "f2b7ad28-643b-44a5-bc1c-9c479432ce70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7744070+00:00"
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
  "subject_id": "b2ef0785-6e79-4c01-9b53-cbe5b9823909",
  "subject_name": "django/db/models/fields/__init__::PositiveIntegerField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
