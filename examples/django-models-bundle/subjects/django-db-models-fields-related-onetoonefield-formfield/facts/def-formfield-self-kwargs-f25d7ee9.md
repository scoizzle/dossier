# Fact f25d7ee9

Store id: 00af234c-f369-488d-9909-a762cd85d323

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
- posted_at: `2026-11-09T23:44:51.6192740+00:00`

## Data

```json
{
  "end_line": 1384,
  "entity_kind": "method",
  "parent": "OneToOneField",
  "start_line": 1381,
  "symbol": "OneToOneField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1381,"selector":"L1381-L1384","symbol":"OneToOneField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1384,
    "entity_kind": "method",
    "parent": "OneToOneField",
    "start_line": 1381,
    "symbol": "OneToOneField.formfield"
  },
  "id": "00af234c-f369-488d-9909-a762cd85d323",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6192740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1381,
        "selector": "L1381-L1384",
        "symbol": "OneToOneField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e90042cd-cb9e-4392-9d6c-3a82bddd5f3e",
  "subject_name": "django/db/models/fields/related::OneToOneField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
