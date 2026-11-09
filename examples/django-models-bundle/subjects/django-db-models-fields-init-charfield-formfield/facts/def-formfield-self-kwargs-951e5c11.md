# Fact 951e5c11

Store id: 61ed5aff-1f32-40e7-9502-fe9c85f557ee

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
- posted_at: `2026-11-09T23:44:50.0709420+00:00`

## Data

```json
{
  "end_line": 1351,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1342,
  "symbol": "CharField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1342,"selector":"L1342-L1351","symbol":"CharField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1351,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1342,
    "symbol": "CharField.formfield"
  },
  "id": "61ed5aff-1f32-40e7-9502-fe9c85f557ee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0709420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1342,
        "selector": "L1342-L1351",
        "symbol": "CharField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "12891308-9074-4bfd-b9a9-c19dc916859d",
  "subject_name": "django/db/models/fields/__init__::CharField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
