# Fact 81e403d1

Store id: 9bf28fdd-32f7-4ef3-bcc9-b2ac571ff442

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
- posted_at: `2026-11-09T23:44:50.6668450+00:00`

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
  "id": "9bf28fdd-32f7-4ef3-bcc9-b2ac571ff442",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6668450+00:00"
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
  "subject_id": "72a1bdad-cc53-4d93-9bbe-065bb5c13b12",
  "subject_name": "django/db/models/fields/files::FileField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
