# Fact 9270fbe8

Store id: 391cdfff-9401-420c-a7eb-e04ecea516b3

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
- posted_at: `2026-11-09T22:39:42.5445160+00:00`

## Data

```json
{
  "end_line": 2238,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2232,
  "symbol": "IntegerField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2232,"selector":"L2232-L2238","symbol":"IntegerField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2238,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2232,
    "symbol": "IntegerField.formfield"
  },
  "id": "391cdfff-9401-420c-a7eb-e04ecea516b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5445160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2232,
        "selector": "L2232-L2238",
        "symbol": "IntegerField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "676600b0-a8b2-449c-b806-f9ae8ae3a40f",
  "subject_name": "django/db/models/fields/__init__::IntegerField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
