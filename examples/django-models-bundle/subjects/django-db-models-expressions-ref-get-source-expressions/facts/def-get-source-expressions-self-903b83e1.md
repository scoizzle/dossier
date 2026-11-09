# Fact 903b83e1

Store id: 4e61c02d-6a7e-4c50-b96d-9e47ded38447

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:31:55.9133930+00:00`

## Data

```json
{
  "end_line": 1461,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1460,
  "symbol": "Ref.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1460,"selector":"L1460-L1461","symbol":"Ref.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1461,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1460,
    "symbol": "Ref.get_source_expressions"
  },
  "id": "4e61c02d-6a7e-4c50-b96d-9e47ded38447",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9133930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1460,
        "selector": "L1460-L1461",
        "symbol": "Ref.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "16243cdf-44ac-431e-a57d-876c0f13c662",
  "subject_name": "django/db/models/expressions::Ref.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
