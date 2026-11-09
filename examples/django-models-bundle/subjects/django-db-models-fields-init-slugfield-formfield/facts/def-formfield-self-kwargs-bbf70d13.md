# Fact bbf70d13

Store id: 41f9aa5c-4b6e-4416-ad5d-01d3aaa2a739

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
- posted_at: `2026-11-09T23:44:50.2323950+00:00`

## Data

```json
{
  "end_line": 2521,
  "entity_kind": "method",
  "parent": "SlugField",
  "start_line": 2514,
  "symbol": "SlugField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2514,"selector":"L2514-L2521","symbol":"SlugField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SlugField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2521,
    "entity_kind": "method",
    "parent": "SlugField",
    "start_line": 2514,
    "symbol": "SlugField.formfield"
  },
  "id": "41f9aa5c-4b6e-4416-ad5d-01d3aaa2a739",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2323950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2514,
        "selector": "L2514-L2521",
        "symbol": "SlugField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4d495a1d-36aa-435e-bcc5-fd18415b45bd",
  "subject_name": "django/db/models/fields/__init__::SlugField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
