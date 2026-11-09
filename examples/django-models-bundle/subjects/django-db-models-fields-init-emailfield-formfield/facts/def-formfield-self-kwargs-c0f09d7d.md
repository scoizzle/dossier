# Fact c0f09d7d

Store id: 4d5504c0-61e3-4b48-8138-9b1ee2dad6e8

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
- posted_at: `2026-11-09T23:31:56.6660570+00:00`

## Data

```json
{
  "end_line": 2020,
  "entity_kind": "method",
  "parent": "EmailField",
  "start_line": 2012,
  "symbol": "EmailField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2012,"selector":"L2012-L2020","symbol":"EmailField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::EmailField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2020,
    "entity_kind": "method",
    "parent": "EmailField",
    "start_line": 2012,
    "symbol": "EmailField.formfield"
  },
  "id": "4d5504c0-61e3-4b48-8138-9b1ee2dad6e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6660570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2012,
        "selector": "L2012-L2020",
        "symbol": "EmailField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1dec1561-99e9-43c7-bbd5-4d612ea6f36c",
  "subject_name": "django/db/models/fields/__init__::EmailField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
