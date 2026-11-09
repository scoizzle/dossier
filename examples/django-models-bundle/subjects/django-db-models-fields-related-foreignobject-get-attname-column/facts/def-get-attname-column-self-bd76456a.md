# Fact bd76456a

Store id: a4a6c828-5930-4490-8769-34ab34309eeb

## Text

```text
def get_attname_column(self)
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
- posted_at: `2026-11-09T23:44:51.5405330+00:00`

## Data

```json
{
  "end_line": 852,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 850,
  "symbol": "ForeignObject.get_attname_column"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":850,"selector":"L850-L852","symbol":"ForeignObject.get_attname_column"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_attname_column](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 852,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 850,
    "symbol": "ForeignObject.get_attname_column"
  },
  "id": "a4a6c828-5930-4490-8769-34ab34309eeb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5405330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 850,
        "selector": "L850-L852",
        "symbol": "ForeignObject.get_attname_column"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "62e7800c-565b-455d-aadd-60de8310f781",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```
