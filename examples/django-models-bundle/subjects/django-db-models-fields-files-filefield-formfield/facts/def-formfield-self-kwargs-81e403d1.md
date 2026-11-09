# Fact 81e403d1

Store id: eee8b5e6-969c-4a22-aa99-09b3ff61557f

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
- posted_at: `2026-11-09T23:31:57.4126320+00:00`

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
  "id": "eee8b5e6-969c-4a22-aa99-09b3ff61557f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4126320+00:00"
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
  "subject_id": "e41668bd-c5ef-4642-965d-181ff6e75b5a",
  "subject_name": "django/db/models/fields/files::FileField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
