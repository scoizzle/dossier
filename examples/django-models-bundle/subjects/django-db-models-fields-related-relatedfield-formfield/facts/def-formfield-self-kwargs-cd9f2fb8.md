# Fact cd9f2fb8

Store id: 21ad65ea-43d4-4de3-96bf-2160e0c21a1f

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
- posted_at: `2026-11-09T22:39:44.2857340+00:00`

## Data

```json
{
  "end_line": 512,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 492,
  "symbol": "RelatedField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":492,"selector":"L492-L512","symbol":"RelatedField.formfield"}`

## Items

```json
[
  {
    "text": "Pass ``limit_choices_to`` to the field being constructed.",
    "locator": {
      "line": 493
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 512,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 492,
    "symbol": "RelatedField.formfield"
  },
  "id": "21ad65ea-43d4-4de3-96bf-2160e0c21a1f",
  "items": [
    {
      "locator": {
        "line": 493
      },
      "text": "Pass ``limit_choices_to`` to the field being constructed."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2857340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 492,
        "selector": "L492-L512",
        "symbol": "RelatedField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "a5fbf87e-c0d0-4137-a0d7-241dbdb2475b",
  "subject_name": "django/db/models/fields/related::RelatedField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
