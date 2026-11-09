# Fact c0f09d7d

Store id: cc7a5b70-80ab-4df7-a6ac-8521c163305f

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
- posted_at: `2026-11-09T23:44:50.1410700+00:00`

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
  "id": "cc7a5b70-80ab-4df7-a6ac-8521c163305f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1410700+00:00"
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
  "subject_id": "c26bb7e0-5160-44d0-8b60-6d262453756b",
  "subject_name": "django/db/models/fields/__init__::EmailField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
