# Fact 926bdb18

Store id: 918bbff7-11e5-4c2b-9892-0ba4aeef9f06

## Text

```text
def get_choices( self, include_blank=True, blank_choice=None, limit_choices_to=None, ordering=(), )
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
- posted_at: `2026-11-09T23:44:52.4815430+00:00`

## Data

```json
{
  "end_line": 192,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 172,
  "symbol": "ForeignObjectRel.get_choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":172,"selector":"L172-L192","symbol":"ForeignObjectRel.get_choices"}`

## Items

```json
[
  {
    "text": "Return choices with a default blank choices included, for use as <select> choices for this field.",
    "locator": {
      "line": 179
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 192,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 172,
    "symbol": "ForeignObjectRel.get_choices"
  },
  "id": "918bbff7-11e5-4c2b-9892-0ba4aeef9f06",
  "items": [
    {
      "locator": {
        "line": 179
      },
      "text": "Return choices with a default blank choices included, for use as <select> choices for this field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4815430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 172,
        "selector": "L172-L192",
        "symbol": "ForeignObjectRel.get_choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "817b331e-f416-47f2-9b4e-0c36340e2432",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_choices",
  "tags": [
    "entity:method"
  ],
  "text": "def get_choices( self, include_blank=True, blank_choice=None, limit_choices_to=None, ordering=(), )"
}
```
