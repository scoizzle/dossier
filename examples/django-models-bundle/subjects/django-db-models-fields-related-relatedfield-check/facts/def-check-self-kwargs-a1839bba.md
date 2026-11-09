# Fact a1839bba

Store id: 0b2c2045-2a69-4eec-b3d0-0dd91cccc3e1

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:58.6042720+00:00`

## Data

```json
{
  "end_line": 133,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 125,
  "symbol": "RelatedField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":125,"selector":"L125-L133","symbol":"RelatedField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 133,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 125,
    "symbol": "RelatedField.check"
  },
  "id": "0b2c2045-2a69-4eec-b3d0-0dd91cccc3e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6042720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 125,
        "selector": "L125-L133",
        "symbol": "RelatedField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "b80f3717-be0a-4c8d-8048-d28f80adc6b6",
  "subject_name": "django/db/models/fields/related::RelatedField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
