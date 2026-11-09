# Fact f37998af

Store id: 10e9d961-2d19-42ec-9e40-d42b418bd265

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
- posted_at: `2026-11-09T22:39:42.5261280+00:00`

## Data

```json
{
  "end_line": 2138,
  "entity_kind": "method",
  "parent": "FloatField",
  "start_line": 2132,
  "symbol": "FloatField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2132,"selector":"L2132-L2138","symbol":"FloatField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FloatField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2138,
    "entity_kind": "method",
    "parent": "FloatField",
    "start_line": 2132,
    "symbol": "FloatField.formfield"
  },
  "id": "10e9d961-2d19-42ec-9e40-d42b418bd265",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5261280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2132,
        "selector": "L2132-L2138",
        "symbol": "FloatField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "cb7b9859-a569-4321-a7d3-6bd69fd3eec9",
  "subject_name": "django/db/models/fields/__init__::FloatField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
