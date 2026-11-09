# Fact 05944b21

Store id: a9ccf9fd-0070-4e79-b2e9-fd48784dd764

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.1548590+00:00`

## Data

```json
{
  "end_line": 2118,
  "entity_kind": "method",
  "parent": "FloatField",
  "start_line": 2117,
  "symbol": "FloatField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2117,"selector":"L2117-L2118","symbol":"FloatField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FloatField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2118,
    "entity_kind": "method",
    "parent": "FloatField",
    "start_line": 2117,
    "symbol": "FloatField.get_internal_type"
  },
  "id": "a9ccf9fd-0070-4e79-b2e9-fd48784dd764",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1548590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2117,
        "selector": "L2117-L2118",
        "symbol": "FloatField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4d6960af-5af6-4bee-8687-08020c49a533",
  "subject_name": "django/db/models/fields/__init__::FloatField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
