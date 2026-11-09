# Fact 81e403d1

Store id: 4b8de8fd-39ea-44f9-b37d-efc11e709115

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
- posted_at: `2026-11-09T22:39:43.2514560+00:00`

## Data

```json
{
  "end_line": 380,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 373,
  "symbol": "FileField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":373,"selector":"L373-L380","symbol":"FileField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 380,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 373,
    "symbol": "FileField.formfield"
  },
  "id": "4b8de8fd-39ea-44f9-b37d-efc11e709115",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2514560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 373,
        "selector": "L373-L380",
        "symbol": "FileField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "ee008e2b-8a54-4e0b-878c-54760afc46f5",
  "subject_name": "django/db/models/fields/files::FileField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
