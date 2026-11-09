# Fact cd9f2fb8

Store id: 479896a5-08e6-4152-9979-8151aa442cad

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
- posted_at: `2026-11-09T23:31:58.6403440+00:00`

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
  "id": "479896a5-08e6-4152-9979-8151aa442cad",
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
    "posted_at": "2026-11-09T23:31:58.6403440+00:00"
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
  "subject_id": "ee4eef9f-18f2-4e46-be7b-1c2b213bf725",
  "subject_name": "django/db/models/fields/related::RelatedField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
